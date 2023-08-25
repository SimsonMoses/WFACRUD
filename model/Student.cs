using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACRUD.model
{
    internal class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("gpa")]
        public Double Gpa { get; set; }

        public Student (string  name, Double gpa)
        {
            Name = name;
            Gpa = gpa;
        }
    }
}
