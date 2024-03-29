using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using aspnetefdemo;

namespace src.Migrations
{
    [ContextType(typeof(DemoContext))]
    partial class DemoContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("aspnetefdemo.Country", b =>
                    {
                        b.Property<string>("CountryName")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<long>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}
