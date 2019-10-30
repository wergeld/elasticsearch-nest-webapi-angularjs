# elasticsearch-nest-webapi-angularjs
Introduction to Elasticsearch 7.4.0 with NEST, ASP.NET Web API 2 and AngularJS

##Installation

* Install Elasticsearch 7.4.x from https://www.elastic.co/downloads/elasticsearch
* Ensure Elasticsearch is listening on http://localhost:9200/ (or whatever machine it is on - update Web.config and ElasticConfig.cs to update)

##Download test data

* Download test data from https://archive.org/download/stackexchange,
* Unzip the archive and copy the `Posts.xml` file to the `elasticsearch-nest-webapi-angularjs\data` folder.

##Create the index
* Send to ES:
PUT /stackoverflow
{
  "mappings": {
    "properties": {
      "answerCount": {
        "type": "integer"
      },
      "body": {
          "type" : "text",
          "fields" : {
            "keyword" : {
              "type" : "keyword"
            }
          }
      },
      "creationDate": {
        "type": "date"
      },
      "id": {
          "type" : "text",
          "fields" : {
            "keyword" : {
              "type" : "keyword"
            }
          }
      },
      "score": {
        "type": "integer"
      },
      "suggest": {
        "type": "completion",
        "analyzer": "simple",
        "search_analyzer": "keyword",
        "preserve_separators": true,
        "preserve_position_increments": true,
        "max_input_length": 50
      },
      "tags": {
          "type" : "text",
          "fielddata": true,
          "fields" : {
            "keyword" : {
              "type" : "keyword"
            }
          }
      },
      "title": {
          "type" : "text",
          "fields" : {
            "keyword" : {
              "type" : "keyword"
            }
          }
      }
    }
  }
}
* Open the solution in Visual Studio 2015+, select Restore NuGet packages and rebuild the solution.
* Make a GET request to http://localhost:53694/api/index?fileName=posts.xml&maxItems=10000

##Run the application
* Debug or Start without debugging to run the Web API in IIS Express.
* Browse to http://localhost:53694/index.html


##In Progress:
Learning C# as I go. Many thanks to original repo: https://github.com/rseniuta/elasticsearch-nest-webapi-angularjs
