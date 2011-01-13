using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheEntities;
using System.Runtime.Serialization;

namespace TheEntities
{

    [DataContract(IsReference=true)] 
    [KnownType(typeof(Question))]
    [KnownType(typeof(Answer))]
    [KnownType(typeof(QuestionComment))]
    public class Question
    {
        [DataMember] public virtual int QuestionId { get; set; }

        [DataMember] public virtual string TheQuestion { get; set; }
        [DataMember] public virtual string Poster { get; set; }

        [DataMember] public virtual IList<QuestionComment> Comments { get; set; }
        [DataMember] public virtual IList<Answer> Answers { get; set; }
    }

    [DataContract]    
    [KnownType(typeof(Question))]
    [KnownType(typeof(QuestionComment))]
    public class QuestionComment
    {

        [DataMember] public virtual Question Question { get; set; }

        [DataMember] public virtual int QuestionCommentId { get; set; }

        [DataMember] public virtual string TheQuestionComment { get; set; }
        [DataMember] public virtual string Poster { get; set; }
    }


    [DataContract(IsReference=true)]
    [KnownType(typeof(Question))]
    [KnownType(typeof(Answer))]
    [KnownType(typeof(AnswerComment))]
    public class Answer
    {
        [DataMember] public virtual Question Question { get; set; }

        [DataMember] public virtual int AnswerId { get; set; }

        [DataMember] public virtual string TheAnswer { get; set; }
        [DataMember] public virtual string Poster { get; set; }

        [DataMember] public virtual IList<AnswerComment> Comments { get; set; }
    }


    [DataContract]
    [KnownType(typeof(Answer))]
    [KnownType(typeof(AnswerComment))]
    public class AnswerComment
    {
        [DataMember] public virtual Answer Answer { get; set; }

        [DataMember] public virtual int AnswerCommentId { get; set; }

        [DataMember] public virtual string TheAnswerComment { get; set; }
        [DataMember] public virtual string Poster { get; set; }
    }


}



