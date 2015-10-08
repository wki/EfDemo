using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EfDemo;

namespace EfDemo.Migrations
{
    [DbContext(typeof(Db))]
    partial class initialcheckin
    {
        public override string Id
        {
            get { return "20151008175930_initial-checkin"; }
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540");

            modelBuilder.Entity("EfDemo.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .Annotation("Relational:ColumnName", "personid");

                    b.Property<string>("Name")
                        .Annotation("Relational:ColumnName", "name");

                    b.Key("PersonId");

                    b.Annotation("Relational:TableName", "person");
                });
        }
    }
}
