using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entity
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }
        public bool Verification { get; set; }
    }
}
