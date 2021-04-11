﻿using System.Collections.Generic;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {

    }
}
