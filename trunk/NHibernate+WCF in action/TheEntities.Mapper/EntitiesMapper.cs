using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.LowercaseSystem;
using FluentNHibernate.Mapping;

namespace TheEntities.Mapper
{
    public class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {

            Not.LazyLoad();
            Id(x => x.QuestionId).GeneratedBy.Sequence("question_seq");

            Map(x => x.TheQuestion).Not.Nullable();
            Map(x => x.Poster).Not.Nullable();

            HasMany(x => x.Comments).Inverse().Not.LazyLoad().Cascade.AllDeleteOrphan();
            HasMany(x => x.Answers).Inverse().Not.LazyLoad().Cascade.AllDeleteOrphan();
        }
    }

    public class QuestionCommentMap : ClassMap<QuestionComment>
    {
        public QuestionCommentMap()
        {
            Not.LazyLoad();
            References(x => x.Question);    

            Id(x => x.QuestionCommentId).GeneratedBy.Sequence("question_comment_seq");

            Map(x => x.TheQuestionComment).Not.Nullable();
            Map(x => x.Poster).Not.Nullable();
        }
    }

    public class AnswerMap : ClassMap<Answer>
    {
        public AnswerMap()
        {
            Not.LazyLoad();
            References(x => x.Question);

            Id(x => x.AnswerId).GeneratedBy.Sequence("answer_seq");

            Map(x => x.TheAnswer).Not.Nullable();
            Map(x => x.Poster).Not.Nullable();

            HasMany(x => x.Comments).Inverse().Not.LazyLoad().Cascade.AllDeleteOrphan();
        }
    }

    public class AnswerCommentMap : ClassMap<AnswerComment>
    {
        public AnswerCommentMap()
        {
            Not.LazyLoad();
            References(x => x.Answer).Not.Nullable();

            Id(x => x.AnswerCommentId).GeneratedBy.Sequence("answer_comment_seq");

            Map(x => x.TheAnswerComment).Not.Nullable();
            Map(x => x.Poster).Not.Nullable();
        }
    }

}
