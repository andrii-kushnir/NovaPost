﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiUkrPost.Base
{
    public class AddressDto
    {
        public long id { get; set; }
        public bool ShouldSerializeid() { return false; }
        public string postcode { get; set; }
        public string country { get; set; } //maxLength: 2
        public string region { get; set; } //maxLength: 25
        public string district { get; set; } //maxLength: 45
        public string city { get; set; } //maxLength: 45
        public string street { get; set; } //maxLength: 255
        public string houseNumber { get; set; } //maxLength: 15
        public string apartmentNumber { get; set; } //maxLength: 15
        public bool countryside { internal get; set; } //True if address located in countryside
        public bool ShouldSerializecountryside() { return false; }
        public bool posteRestante { internal get; set; } //Address for letters delivered with tag by request on sticker
        public bool ShouldSerializeposteRestante() { return false; }
        public string created { internal get; set; } //This address creation time
        public bool ShouldSerializecreated() { return false; }
        public string description { internal get; set; } //maxLength: 255
        public bool ShouldSerializedescription() { return false; }
        public string detailedInfo { internal get; set; }
        public bool ShouldSerializedetailedInfo() { return false; }
        public string foreignStreetHouseApartment { internal get; set; }
        public bool ShouldSerializeforeignStreetHouseApartment() { return false; }
        public string lastModified { internal get; set; } //This address modification time
        public bool ShouldSerializelastModified() { return false; }
        public string mailbox { internal get; set; } //Mailbox number
        public bool ShouldSerializemailbox() { return false; }
        public string specialDestination { internal get; set; } //maxLength: 255
        public bool ShouldSerializespecialDestination() { return false; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}