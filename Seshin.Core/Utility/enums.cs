using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seshin.Core.Utility
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
