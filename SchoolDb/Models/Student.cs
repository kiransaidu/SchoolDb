//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolDb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentsRollNo { get; set; }
        public string StudentsName { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> SubjectId { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
