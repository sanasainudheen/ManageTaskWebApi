using System.ComponentModel.DataAnnotations;

namespace TaskManagerWebApi.Models
{
    public class StatusCount
    {
        [Key]
        //public string StatusId { get; set; }
        public int Count { get; set; }

    }
}
