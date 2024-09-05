namespace dotnet_interview.Models
{
    public class TaskItem
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool completed { get; set; }
        public DateTime completed_on { get; set; }

        public Guid UserId {get; set;}
        public User? User {get; set;}
    }
}