//Band queen = new Band("Queen", "Rock");

//Album queenAlbum = new Album("A night at the opera");

//Music music1 = new Music("Love of my life", queen)
//{
//    Duration = 213,
//    IncluedInPlan = true,
//};

//Music music2 = new Music("Bohemian Rhapsody", queen)
//{
//    Duration = 354,
//    IncluedInPlan = true,
//};

//queenAlbum.AddMusic(music1);
//queenAlbum.AddMusic(music2);
//queen.AddAlbum(queenAlbum);

//music1.ViewTechnicalSheet();
//music2.ViewTechnicalSheet();
//queenAlbum.DisplayMusics();
//queen.ViewDiscography();

PodCast podcast = new PodCast("PodPah", "Igão e Mítico");
Episode episode1 = new Episode(1, "Conversa com o Lactea")
{
    Duration = 120,
};
Episode episode2 = new Episode(2, "Conversa com o Monark e Igor")
{
    Duration = 180,
};
episode1.AddGuests("Lactea");
episode2.AddGuests("Monark");
episode2.AddGuests("Igor");

podcast.AddEpisode(episode1);
podcast.AddEpisode(episode2);
podcast.DisplayDetails();