using Battalion.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Battalion.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult Index()
        {
            //ViewData["Notice"] = db.Notice.ToList();

            //ViewData["WhatsNew"] = db.WhatsNew.ToList();

            //ViewData["Officers"] = db.Officers.ToList();

           


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            //ViewData["Contact"] = db.Contact.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Models.UserContact contact, Int64 ContactID = 0, string Name = null, string Email = null, string Subject = null, string Message = null)
        {
            string Status = "NA";
            try
            {
                var exist = db.UserContact.Find(contact.ContactID);
                if (exist == null)
                {
                    Models.UserContact ct = new Models.UserContact();

                    ct.Name = contact.Name;
                    ct.Email = contact.Email;
                    ct.Subject = contact.Subject;
                    ct.Message = contact.Message;
                    db.UserContact.Add(ct);

                    int result = db.SaveChanges();
                    if (result == 1)
                    {


                        var msg = "<span style='font-weight:bold;color:#900C3F;text-decoration:underline;font-size:Large'>New Contact</span>" +
                            "<br><br><span style='font-weight:bold'>Name :</span>" + " " + "<span style='color:#5D311B;font-weight:bold'>" + contact.Name + "</span>" +
                            "<br><span style='font-weight:bold'> Email :</span>" + " " + "<span style='color:#5D311B;font-weight:bold'>" + contact.Email + "</span>" +

                             "<br/><span style='font-weight:bold'>Subject :</span> " + "<span style='color:#5D311B;font-weight:bold'>" + contact.Subject + "</span>" +
                           "<br/><span style='font-weight:bold'>Message :</span>" + "<span style='color:#5D311B;font-weight:bold'>" + contact.Message + "</span>" +
                             "<br/><br/>Thank you for Contacting with us" + "<br><span style='color:#2867DE;font-weight:bold;font-size:medium'>4th Bn CAF, Mana Camp, Raipur</span>";
                        var sub = contact.Name;
                        var name = contact.Name;
                        string res = SendEmail("vijaydwivedi125@gmail.com", sub, msg, name);
                        Status = "Succeeded";

                    }
                    else
                    {
                        Status = "UnSucceeded";
                    }
                }

                else
                {
                    exist.Name = contact.Name;
                    exist.Email = contact.Email;
                    exist.Subject = contact.Subject;
                    exist.Message = contact.Message;

                    int result = db.SaveChanges();
                    if (result == 1)
                    {
                        Status = "Succeeded";
                    }
                    else
                    {
                        Status = "UnSucceeded";
                    }
                }

            }
            catch (Exception ex)
            {
                Status = "UnSucceeded" + ex;
            }


            ViewBag.Status = Status;


            return RedirectToAction("Index", "Home");
        }

        public ActionResult WebsitePolicies()
        {
            return View();
        }

        public ActionResult Gallery()
        {
           
            return View();
        }

        public ActionResult ActsandRules()
        {
            return View();
        }

        public ActionResult DisttPoliceWebsite()
        {
            return View();
        }

        public ActionResult CGBatalionDetail()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult General()
        {
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult Downloads()
        {
            //ViewData["Downloads"] = db.Downloads.ToList();

            return View();
        }

        public ActionResult CompanyDeployment()
        {
            return View();
        }

        public ActionResult CommandantList()
        {
            return View();
        }

        public ActionResult MedalHolders()
        {
            return View();
        }

        public ActionResult Martyrs()
        {
            return View();
        }

        public ActionResult DistrictPoliceRaipur()
        {
            return View();
        }



        public string SendEmail(string EmailId = null, string subject = null, string msg = null, string Name = null, string Email = null)
        {
            var senderEmail = new MailAddress("smswebhelp@gmail.com", "4th Bn CAF, Mana Camp");
            var receiverEmail = new MailAddress(EmailId, "Receiver");
            var password = "smsweb@2019";
            var sub = subject;
            var body = msg;
            var Cname = Name;
            var cemail = Email;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body

            })
            {
                mess.IsBodyHtml = true;
                smtp.Send(mess);
            }
            return "Done";
        }



    }
}