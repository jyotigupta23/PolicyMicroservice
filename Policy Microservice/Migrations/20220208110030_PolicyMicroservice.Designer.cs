// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Policy_Microservice.Model;

namespace Policy_Microservice.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220208110030_PolicyMicroservice")]
    partial class PolicyMicroservice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Policy_Microservice.Model.Aves", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AGENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CONSUMER_ID")
                        .HasColumnType("int");

                    b.Property<int>("POLICY_ID")
                        .HasColumnType("int");

                    b.Property<int>("PROPERTY_ID")
                        .HasColumnType("int");

                    b.Property<float>("QUOTE")
                        .HasColumnType("real");

                    b.Property<int>("STATUS")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Aves");
                });

            modelBuilder.Entity("Policy_Microservice.Model.Policy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ASSURED_SUM")
                        .HasColumnType("real");

                    b.Property<string>("BASE_LOCATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BUSINESS_VALUE")
                        .HasColumnType("int");

                    b.Property<string>("CONSUMER_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROPERTY_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PROPERTY_VALUE")
                        .HasColumnType("int");

                    b.Property<int>("TENURE")
                        .HasColumnType("int");

                    b.Property<string>("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
