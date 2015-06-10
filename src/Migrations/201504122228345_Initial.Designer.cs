using aspnetefdemo;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using System;

namespace aspnet5ef7.Migrations
{
    [ContextType(typeof(aspnetefdemo.DemoContext))]
    public partial class Initial : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201504122228345_Initial";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta4-12943";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
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