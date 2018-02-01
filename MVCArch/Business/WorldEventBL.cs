using MVCArch.Infrastructure.Utilities;
using MVCArch.Data;
using MVCArch.Models;
using System.Collections.Generic;
using System.Data;


namespace MVCArch.Business
{
    public class WorldEventBL
    {
        readonly WorldEvents _worldEvent;
        readonly Extension _ext;

        internal WorldEventBL(WorldEvents worldEvent)
        {
            _worldEvent = worldEvent;
        }

        internal WorldEventBL(WorldEvents worldEvent, Extension ext)
        {
            _worldEvent = worldEvent;
            _ext = ext;

        }

        internal List<EventDTO> GetEvents()
        {
           DataTable dt = _worldEvent.GetEventDetails();
           return _ext.ConvertTo<EventDTO>(dt);
        }

    }
}