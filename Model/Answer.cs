using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }
        public int Question_Id { get; set; }
    }
}
