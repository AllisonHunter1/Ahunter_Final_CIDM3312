using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ahunter_Final_CIDM3312.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrgProjDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<OrgProjDbContext>>()))
            {
                if (context.Organizations.Any())
                {
                    return; // DB has been seeded
                }

                // Add Organizations
                var organizations = new[]
                {
                    new Organization { Name="Turn Center", Description="Welcome to Turn Center. Our mission is to provide outstanding therapy services while instilling hope in the lives of the families we serve.", ContactEmail="support@turncenter.com" },
                    new Organization { Name="Amarillo Art Institute", Description="Dedicated to providing art education and promoting fine arts in the region", ContactEmail="info@amarilloartinstitute.org" },
                    new Organization { Name="Canyon Cares", Description="Community-focused charity providing assistance to residents in need", ContactEmail="contact@canyoncares.org" },
                    new Organization { Name="Panhandle Plains Historical Museum", Description="Showcasing the history and culture of the Texas Panhandle", ContactEmail="support@panhandleplains.org" },
                    new Organization { Name="Amarillo Wildlife Refuge", Description="Protecting and rehabilitating local wildlife and natural habitats", ContactEmail="info@amarillowildlife.org" },
                    new Organization { Name="Canyon Community Theater", Description="Fostering performing arts in the community", ContactEmail="contact@canyontheater.org" },
                    new Organization { Name="High Plains Food Bank", Description="Working to end hunger in the Texas Panhandle", ContactEmail="support@highplainsfoodbank.org" },
                    new Organization { Name="Amarillo Botanical Gardens", Description="Preserving and displaying native plant species and promoting environmental awareness", ContactEmail="info@amarillobotanical.org" },
                    new Organization { Name="Canyon Historical Society", Description="Preserving the history and heritage of Canyon, Texas", ContactEmail="contact@canyonhistory.org" },
                    new Organization { Name="Amarillo Youth Symphony", Description="Nurturing young musicians and providing orchestral experiences", ContactEmail="info@amarilloyouthsymphony.org" },
                    new Organization { Name="Canyon Animal Shelter", Description="Providing care and finding homes for abandoned animals", ContactEmail="support@canyonanimalshelter.org" },
                    new Organization { Name="Amarillo Literacy Center", Description="Promoting literacy and lifelong learning", ContactEmail="contact@amarilloliteracycenter.org" },
                    new Organization { Name="Canyon Senior Center", Description="Enhancing the quality of life for seniors through various programs", ContactEmail="info@canyonseniorcenter.org" },
                    new Organization { Name="Panhandle Environmental Partnership", Description="Working towards sustainable environmental solutions", ContactEmail="support@panhandleenvironment.org" },
                    new Organization { Name="Amarillo Tech Initiative", Description="Advancing technology education and innovation in the region", ContactEmail="info@amarillotech.org" },
                    new Organization { Name="Canyon Arts Foundation", Description="Supporting local artists and art initiatives", ContactEmail="contact@canyonarts.org" },
                    new Organization { Name="Amarillo Community Gardens", Description="Promoting urban gardening and healthy living", ContactEmail="support@amarillogardens.org" },
                    new Organization { Name="Canyon Music Academy", Description="Offering music education and performance opportunities", ContactEmail="info@canyonmusicacademy.org" },
                    new Organization { Name="Amarillo Health Network", Description="Improving community health and wellness", ContactEmail="contact@amarillohealthnetwork.org" },
                    new Organization { Name="Panhandle Renewable Energy Corp", Description="Promoting renewable energy and sustainability", ContactEmail="support@panhandlerenewable.org" },
                    new Organization { Name="Amarillo Cultural Trust", Description="Preserving and promoting the cultural heritage of the area", ContactEmail="info@amarilloculturaltrust.org" },
                    new Organization { Name="Canyon Youth Sports Association", Description="Encouraging youth sports and physical activity", ContactEmail="contact@canyonyouthsports.org" },
                    new Organization { Name="Amarillo Veterans Support Group", Description="Offering assistance and resources to local veterans", ContactEmail="support@amarilloveterans.org" },
                    new Organization { Name="Canyon Community Outreach", Description="Addressing social and community needs", ContactEmail="info@canyoncommunity.org" },
                    new Organization { Name="Amarillo Innovation Hub", Description="A hub for creative thinkers and startups", ContactEmail="contact@amarilloinnovationhub.org" }
                };
                context.Organizations.AddRange(organizations);

                context.SaveChanges();

                // Add projects
                var projects = new[]
                {
                    new Project { Name="Therapy Trick Or Treat", Description="Volunteer to help hand out candy!", EndDate= new DateTime(2024, 11, 11), OrganizationId= organizations[0].OrganizationID },
                    new Project { Name="Art Workshop for Kids", Description="A creative workshop for children to learn painting", EndDate= new DateTime(2024, 8, 15), OrganizationId= organizations[1].OrganizationID },
                    new Project { Name="Outdoor Sculpture Exhibit", Description="Setting up an outdoor sculpture display", EndDate= new DateTime(2024, 9, 10), OrganizationId= organizations[1].OrganizationID },
                    new Project { Name="Food Drive Campaign", Description="Organizing a food drive for the community", EndDate= new DateTime(2024, 7, 20), OrganizationId= organizations[2].OrganizationID },
                    new Project { Name="Winter Clothing Collection", Description="Collecting warm clothes for those in need", EndDate= new DateTime(2024, 11, 30), OrganizationId= organizations[2].OrganizationID },
                    new Project { Name="Historical Exhibition Setup", Description="Assisting in setting up a new historical exhibit", EndDate= new DateTime(2024, 10, 5), OrganizationId= organizations[3].OrganizationID },
                    new Project { Name="Museum Volunteer Program", Description="Recruiting volunteers for museum activities", EndDate= new DateTime(2024, 12, 15), OrganizationId= organizations[3].OrganizationID },
                    new Project { Name="Wildlife Protection Initiative", Description="Join efforts in local wildlife conservation", EndDate= new DateTime(2024, 6, 30), OrganizationId= organizations[4].OrganizationID },
                    new Project { Name="Theater Set Design", Description="Help design sets for upcoming community theater productions", EndDate= new DateTime(2024, 5, 22), OrganizationId= organizations[5].OrganizationID },
                    new Project { Name="Community Garden Planting", Description="Assist in planting a new community garden", EndDate= new DateTime(2024, 4, 18), OrganizationId= organizations[6].OrganizationID },
                    new Project { Name="Botanical Education Series", Description="Educational series on local plant species", EndDate= new DateTime(2024, 3, 15), OrganizationId= organizations[7].OrganizationID },
                    new Project { Name="Local History Documentation", Description="Documenting local history through interviews and research", EndDate= new DateTime(2024, 2, 12), OrganizationId= organizations[8].OrganizationID },
                    new Project { Name="Youth Orchestra Concert Preparation", Description="Assist in organizing a youth orchestra concert", EndDate= new DateTime(2024, 1, 29), OrganizationId= organizations[9].OrganizationID },
                    new Project { Name="Botanical Workshop Series", Description="Conducting workshops on gardening and plant care", EndDate= new DateTime(2024, 7, 25), OrganizationId= organizations[7].OrganizationID },
                    new Project { Name="Historical Research Project", Description="Engaging in research for a historical publication", EndDate= new DateTime(2024, 8, 30), OrganizationId= organizations[8].OrganizationID },
                    new Project { Name="Youth Music Education Program", Description="Teaching music to young students", EndDate= new DateTime(2024, 9, 20), OrganizationId= organizations[9].OrganizationID },
                    new Project { Name="Animal Adoption Fair", Description="Organizing an event for animal adoption", EndDate= new DateTime(2024, 10, 12), OrganizationId= organizations[10].OrganizationID },
                    new Project { Name="Adult Literacy Workshop", Description="Hosting workshops to improve adult literacy", EndDate= new DateTime(2024, 11, 5), OrganizationId= organizations[11].OrganizationID },
                    new Project { Name="Senior Health Fair", Description="Organizing a health fair for seniors", EndDate= new DateTime(2024, 12, 28), OrganizationId= organizations[12].OrganizationID },
                    new Project { Name="Environmental Awareness Campaign", Description="Raising awareness about environmental issues", EndDate= new DateTime(2024, 1, 15), OrganizationId= organizations[13].OrganizationID },
                    new Project { Name="Technology Skills Workshop", Description="Workshops on improving technology skills", EndDate= new DateTime(2024, 2, 20), OrganizationId= organizations[14].OrganizationID },
                    new Project { Name="Artists Support Initiative", Description="Supporting local artists with resources and networking", EndDate= new DateTime(2024, 3, 25), OrganizationId= organizations[15].OrganizationID },
                    new Project { Name="Music Academy Annual Concert", Description="Preparation and execution of the annual concert", EndDate= new DateTime(2024, 4, 30), OrganizationId= organizations[16].OrganizationID }
                };
                context.Projects.AddRange(projects);

                context.SaveChanges();
            }
        }
    }
}
