using System;
using System.Collections.Generic;
using Nest;

namespace elasticsearch_nest_webapi_angularjs.Models
{
    public class Post
    {
        [Keyword]
        public string Id { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? Score { get; set; }

        public int? AnswerCount { get; set; }

        [Keyword]
        public string Body { get; set; }

        [Keyword]
        public string Title { get; set; }

        [Keyword]
        public IEnumerable<string> Tags { get; set; }

        [Completion]
        public IEnumerable<string> Suggest { get; set; }
    }
}
