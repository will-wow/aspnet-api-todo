using System;
namespace TodoApi.Models
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Title { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}
