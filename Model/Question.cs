using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string IsQuestionState { get; set; }
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }
        public int Question_Id { get; set; }
    }
}
