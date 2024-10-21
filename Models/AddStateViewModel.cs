using System.ComponentModel.DataAnnotations.Schema;

namespace StateMaster.Models
{
    public class AddStateViewModel
    {
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string StateNameEnglish { get; set; }


        [Column(TypeName = "nvarchar(50)")]

        public string StateNameHindi { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string StateNameCode { get; set; }



        public bool Status { get; set; }

    }
}
