using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battalion.Models
{
    //Models for all master entries table
    public class Notice
    {
        [Key]

        public Int64 NoticeID { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
    }



    public class Downloads
    {
        [Key]

        public Int64 DownloadID { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
    }


    public class WhatsNew
    {
        [Key]
        public Int64 WhatsNewID { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
    }

    public class Gallery
    {
        [Key]
        public Int64 GalleryID { get; set; }
        public string File { get; set; }
    }

    public class Contact
    {
        [Key]
        public Int64 ContactID { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Mobile { get; set; }


    }


    public class Officers
    {

        [Key]
        public Int64 OfficersID { get; set; }
        public string OfficerName { get; set; }
        public string Post { get; set; }
        public string Image { get; set; }


    }


    public class UserContact
    {
        [Key]

        public Int64 ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

    }


}