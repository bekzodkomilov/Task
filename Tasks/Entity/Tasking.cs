using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace tasks.Entity
{
    public class Tasking
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Tags { get; set; }
        public DateTimeOffset OnADay { get; set; }
        public DateTimeOffset AtATime { get; set; }
        public ETaskStatus Status { get; set; }
        public ETaskRepeat Repeat { get; set; }
        public ETaskPriorety Priorety { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }

        [Obsolete("Used only for entity binding.", true)]
        public Tasking() { }

        public Tasking(string title, string description ="", string tags ="" , DateTimeOffset onADay = default(DateTimeOffset), DateTimeOffset atATime = default(DateTimeOffset), ETaskStatus status = ETaskStatus.None, ETaskRepeat repeat = ETaskRepeat.Never, ETaskPriorety priorety = ETaskPriorety.None, string location ="", string url = "" )
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Tags = tags;
            OnADay = onADay;
            AtATime = atATime;
            Status = status;
            Repeat = repeat;
            Priorety = priorety;
            Location = location;
            Url = url;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}