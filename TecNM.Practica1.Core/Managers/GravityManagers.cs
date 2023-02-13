using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class GravityManagers : IGravityManagers{

    private readonly IGravityService _service;

    public GravityManagers(IGravityService service){
        _service = service;
    }

    public Gravity getGravity(Person person){
        return _service.ProcessGravity(person);
    }

}