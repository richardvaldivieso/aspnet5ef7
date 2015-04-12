using aspnetefdemo;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using System;

namespace aspnet5ef7.Migrations
{
    [ContextType(typeof(aspnetefdemo.DemoContext))]
    public class DemoContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("aspnetefdemo.Country", b =>
                    {
                        b.Property<string>("CountryName");
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}