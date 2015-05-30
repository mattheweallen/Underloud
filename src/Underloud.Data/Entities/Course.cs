using System.ComponentModel.DataAnnotations;

namespace Underloud.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public SportType GameType { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
