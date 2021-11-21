using Microsoft.EntityFrameworkCore.Migrations;

namespace UndergroundConnectionsApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Age", "Bio", "Email", "Name", "PastWork", "Seeking" },
                values: new object[,]
                {
                    { 1, 19, "Hey yall I make macaroni art and music", "marni@yomama.com", "Marni On Rails", "Eiffle tower made out of penne", "Photographers" },
                    { 2, 65, "Wonder if you'll ever have a woman like me, wonderwoman is who I be", "sisi@yomama.com", "Gozi", "I killed a lot of bad guys", "Rappers" },
                    { 3, 4, "I'm Mike cheese aka the big cheese", "daddy@yomama.com", "Mike Cheese", "Past work? Look no further, this biceps are years in the making", "Painters" },
                    { 4, 50, "I love myself like kanye likes kanye", "ye@yomama.com", "Kanye Rest", "Your childhood music is me", "Producer" },
                    { 5, 27, "Wonder if you'll ever have a woman like me, wonderwoman is who I be", "starynite@yomama.com", "Van Gno", "I killed a lot of bad guys", "Graphic Designer" },
                    { 6, 23, "I'm looking only for the peak of human life", "hipster_garbo@yomama.com", "Mouse and String", "Cats, the Musical 2.0", "Xylophonist's" },
                    { 7, 18, "Bringing you the best of salt extravaganza, each and every day!", "Salty_blanket@yomama.com", "Salt Shank", "Bucket of salty salmon", "Screamers" },
                    { 8, 66, "Always striving to extract the most profound CRUCH out of my clients.", "crunchdaddy@yomama.com", "Crunchist", "Cap'n Crunch commercial theme", "DJ's" },
                    { 9, 29, "If you want it lets do it", "papi@yomama.com", "Magic Mike", "Just put on pony and I'll show you my past work", "Singer" },
                    { 10, 46, "I will talk to you all night long.", "phoneme@yomama.com", "Don't Hang Up", "Many conversations recorded and replayed", "Videographers" },
                    { 11, 36, "Don't mess with me or I will punch your lights out", "biker@yomama.com", "Dusty Hogg", "I beat the shit out of people", "Rappers" },
                    { 12, 32, "I will predict your future by connecting with the spirits", "psychicmeera@yomama.com", "Meera Lax", "I helped many find their spiritual purposes.", "Painters" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 12);
        }
    }
}
