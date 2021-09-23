using System.ComponentModel.DataAnnotations.Schema;

namespace mysqltest.Models
{
    public class StudentClub
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        public Club Club { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}