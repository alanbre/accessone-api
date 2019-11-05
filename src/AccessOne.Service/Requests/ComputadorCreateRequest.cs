using AccessOne.Service.Responses;

namespace AccessOne.Service.Requests
{
    public class ComputadorCreateRequest
    {
        public string Nome { get; set; }
        public string Ip { get; set; }
        public int Disco { get; set; }
        public int Memoria { get; set; }
        public GrupoResponse Grupo { get; set; }
    }
}