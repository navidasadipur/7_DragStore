using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugStore7.Core.Utility
{
    public enum DiscountType
    {
        Percentage = 1,
        Amount = 2
    }
    public enum GeoDivisionType
    {
        Country = 0,
        State = 1,
        City = 2,
    }

    public enum StaticContents
    {
        Phone = 1005,
        Map = 2005,
        Address = 6,
        WorkingHours = 1008,
        Email = 2,
        Youtube = 2007,
        Instagram = 2012,
        Twitter = 2013,
        Pinterest = 2014,
        Facebook = 2015,
        BlogImage = 1013,
        ContactInfo = 1014,
        companyServices = 3003,
        CopyRight = 3004,
        ImplementaitonService = 3005,

        DiscountNews = 5027,

        Logo = 3,
        BackGroundImage = 4022,
    }

    public enum StaticContentTypes
    {
        Slider = 1,
        ContactUsMap = 2,
        Address = 6,
        Email = 7,
        Phone = 8,
        Guide = 9,
        Popup = 11,
        PageBanner=12
    }

    public enum PaymentStatus
    {
        Unprocessed = 1,
        Failed =2,
        Succeed =3,
        Expired = 4
    }

    public enum AditionalFeatureType
    {
        Volume = 1
    }

}
