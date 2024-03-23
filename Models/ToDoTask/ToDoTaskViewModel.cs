namespace ToDoList.Models.ToDoTask
{
    public class ToDoTaskViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? StartDay { get; set; }
        public string? EndDay { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
    }
}
