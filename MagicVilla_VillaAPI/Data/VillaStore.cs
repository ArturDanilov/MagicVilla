using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villasList { get; set; } = new List<VillaDTO> 
        {
            new VillaDTO { Id = 1, Name = "Villa 1"},
            new VillaDTO { Id = 2, Name = "Villa 2"},
            new VillaDTO { Id = 3, Name = "Villa 3"}
        };
    }
}
