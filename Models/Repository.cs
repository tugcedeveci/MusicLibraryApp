namespace MusicLibraryApp.Models
{
     public class Repository
     {
        private static readonly List<Music> 
        _music = new();

        static Repository(){
            _music = new List<Music>(){

            new Music(){Id=1,Title="Look What You Made Me Do",Artist="Taylor Swift",Year=2017,Description=" Dans-Pop, Progressive pop",Album= "Reputation", Image="1.jpg" , Tags= new string[]{"taylor","swift","pop"}, IsActive=true,IsHome=true},

            new Music(){Id=2,Title="Single Soon",Artist="Selena Gomez",Year=2023,Description=" Dans-Pop, Pop, Country",Album= "Single Soon" ,Image="2.jpg", Tags= new string[]{"selena","gomez","pop"}, IsActive=true,IsHome=true},

            new Music(){Id=3,Title="Deja Vu",Artist="Olivia Rodrigo",Year=2021,Description="Pop Rock, İndie Pop, R&B/Soul",Album= "Sour",Image="3.jpg" , IsActive=true,IsHome=false},
            
            new Music(){Id=4,Title="Agora Hills",Artist="Doja Cat",Year=2023,Description="Hip-Hop/Rap",Album= "Scarlet",Image="4.jpg" , IsActive=true,IsHome=true},

            new Music(){Id=5,Title="Snooze",Artist="SZA",Year=2022,Description="R&B/Soul",Album= "SOS",Image="5.jpg",IsActive=true,IsHome=true }
            };
        }

        public static List<Music> Musics{
            get{
                return _music;
            }
        }
        public static Music? GetById(int? id){
            return _music.FirstOrDefault(c => c.Id ==id);
        }

     }
}