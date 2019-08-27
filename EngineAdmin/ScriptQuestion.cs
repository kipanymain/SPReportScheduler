//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EngineAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScriptQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScriptQuestion()
        {
            this.ScriptQuestionareDetails = new HashSet<ScriptQuestionareDetail>();
        }
    
        public int ScriptQuestionID { get; set; }
        public string QuestionDesc { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string ResponseType { get; set; }
        public string Choices { get; set; }
        public Nullable<int> MaxLength { get; set; }
        public Nullable<int> MinimumValue { get; set; }
        public Nullable<int> MaximumValue { get; set; }
        public Nullable<bool> PastDatesOK { get; set; }
        public Nullable<bool> AnswerRequired { get; set; }
        public Nullable<int> ScriptValidatorID { get; set; }
        public string KeyCodes { get; set; }
        public Nullable<int> ScriptLookupID { get; set; }
        public string DataObjectField { get; set; }
        public string DOValueColumn { get; set; }
        public string DODisplayColumns { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateLastModified { get; set; }
        public string UserLastModified { get; set; }
        public string ClientID { get; set; }
        public string QuestionFooter { get; set; }
    
        public virtual ScriptValidator ScriptValidator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScriptQuestionareDetail> ScriptQuestionareDetails { get; set; }
    }
}