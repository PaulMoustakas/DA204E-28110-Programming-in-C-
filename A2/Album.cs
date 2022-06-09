class Album {

    private String albumName;
    private String artistName; 
    private int nbmOfTracks; 



    private void AlbumInput () {
        Console.WriteLine("Starting the Album program!"); 

        // Album 
        Console.WriteLine("What is the name of your favorite music album?");
        albumName = Console.ReadLine(); 

        // Artist 
        Console.WriteLine("What is the name of the Artist or Band for " + albumName+ "?");
        artistName = Console.ReadLine();

        // Tracks 
        Console.WriteLine("How many tracks does " +albumName+ " have?");
        nbmOfTracks = int.Parse( Console.ReadLine()); 
    }



    private void AlbumPrint () {
        Console.WriteLine();
        Console.WriteLine("Album name: " + albumName);
        Console.WriteLine("Artist/Band: " + artistName);
        Console.WriteLine("Number of Tracks: " + nbmOfTracks);
        Console.WriteLine("Enjoy listening!");
    }


    public void Start() {
        AlbumInput(); 
        AlbumPrint(); 
    }

}