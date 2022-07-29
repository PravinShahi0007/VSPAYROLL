using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VSPAYROLL.Models;

namespace VSPAYROLL.Controllers
{
    public class HomeController : Controller
    {

        private zkemkeeper.CZKEM cZKEM = new zkemkeeper.CZKEM(); 

        private DateTime createdOn = DateTime.Now;

        private bool IsRead = false;

        string dwEnrollNumber;
        
        int dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkcode, dwMachineNumber;  
        public string IPAdd { get; private set; }
        int Port { get; set; }
        int Support;
        string BeginTime;
        string EndTime;
        public int ComPort { get; private set; }
        public async Task<ActionResult> Index()
        {
            
            ViewBag.Title = "Home Page";
            await Create2();
            return View();
        }

        public async Task Create2()
        {
            using (var ctx = new DataBaseContext())
            {

                var query = ctx.BiometricMasters.Where(x => x.Status).ToList();

                foreach (var obj in query)
                {
                    bool bIsConnected = cZKEM.Connect_Net(obj.IPAddress, obj.Port);   // 4370 is port no of attendance machine

                    if (bIsConnected == true)
                    {

                        dwMachineNumber = 1;

                        IsRead = cZKEM.ReadGeneralLogData(dwMachineNumber);

                        if (IsRead == true)
                        {

                            while (cZKEM.SSR_GetGeneralLogData(dwMachineNumber, out dwEnrollNumber, out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, ref dwWorkcode))

                            {
                                cZKEM.GetDaylight(dwMachineNumber, ref Support, ref BeginTime, ref EndTime);

                                cZKEM.GetSerialNumber(dwMachineNumber, out string dwSerialNumber);

                                using(var db = new DataBaseContext())
                                {
                                    var list = db.PayAttImports.Where(z => z.SerialNo == dwSerialNumber).ToList();

                                    DateTime serialnomatch = new DateTime(1990, 01, 01);
                                    
                                    if(list.Count() > 0)
                                    {
                                        serialnomatch = list.Max(x => x.PunchDate);
                                    } 

                                    DateTime inputDate = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond);


                                    if (inputDate > serialnomatch || serialnomatch == null)
                                    {
                                        PayAttImport payAttImport = new PayAttImport();

                                        payAttImport.ConCode = 1;

                                        payAttImport.CreatedBy = 1;
                                        payAttImport.PunchDateTime = inputDate;
                                        payAttImport.PunchDate = DateTime.Parse(DateTime.Parse((payAttImport.PunchDateTime).ToString()).ToString("yyyy-MM-dd"));
                                        payAttImport.MachineNumber = Convert.ToInt32(dwMachineNumber).ToString();
                                        payAttImport.TicketNo = dwEnrollNumber;
                                        payAttImport.CreatedAt = createdOn;
                                        payAttImport.TakeFlag = "No";
                                        payAttImport.Level = false;
                                        payAttImport.Mcid = dwEnrollNumber;
                                        payAttImport.SerialNo = dwSerialNumber;
                                        payAttImport.Direction = obj.Direction;
                                        payAttImport.LevelCode = 1;


                                        db.PayAttImports.Add(payAttImport);
                                        await db.SaveChangesAsync();
                                    }
                                    db.Dispose();
                                } 
                            }

                        }
                    }


                }
            }

        }


    }
}
