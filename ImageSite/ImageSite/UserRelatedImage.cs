//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRelatedImage
    {
        public UserRelatedImage()
        {
            this.ImageReported = new HashSet<ImageReported>();
        }
    
        public int UserImageID { get; set; }
        public string ImageTitle { get; set; }
        public byte[] UserImage { get; set; }
        public Nullable<System.DateTime> DateImageAdded { get; set; }
        public string ImageSize { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual ICollection<ImageReported> ImageReported { get; set; }
        public virtual UserAuthentication UserAuthentication { get; set; }
    }
}
