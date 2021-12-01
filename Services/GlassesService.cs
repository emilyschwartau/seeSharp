using seeSharp.Models;

namespace seeSharp.Services;

public static class GlassesService
{
    static List<Glasses> ListOfGlasses { get; }
    static int nextId = 3;
    static GlassesService()
    {
        ListOfGlasses = new List<Glasses>
        {
            new Glasses { Id = 1, Name = "bifocals", Color = "black", Shape = "square" },
            new Glasses { Id = 2, Name = "sunglasses", Color = "red", Shape = "round" }
        };
    }

    public static List<Glasses> GetAll() => ListOfGlasses;

    public static Glasses? Get(int id) => ListOfGlasses.FirstOrDefault(p => p.Id == id);

    public static void Add(Glasses glasses)
    {
        glasses.Id = nextId++;
        ListOfGlasses.Add(glasses);
    }

    public static void Delete(int id)
    {
        var pair = Get(id);
        if(pair is null)
            return;

        ListOfGlasses.Remove(pair);
    }

    public static void Update(Glasses glasses)
    {
        var index = ListOfGlasses.FindIndex(p => p.Id == glasses.Id);
        if(index == -1)
            return;

        ListOfGlasses[index] = glasses;
    }
}