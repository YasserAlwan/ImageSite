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
    
    public partial class UserLikeCommentAdded
    {
        public int UserCommentLikeID { get; set; }
        public Nullable<int> UserCommentLike { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> UserCommentID { get; set; }
    
        public virtual UserAuthentication UserAuthentication { get; set; }
        public virtual UserRelatedComment UserRelatedComment { get; set; }
    }
}