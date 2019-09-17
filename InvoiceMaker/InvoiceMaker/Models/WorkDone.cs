﻿using System;

namespace InvoiceMaker.Models
{
    public class WorkDone
    {
        private Client _client;
        private WorkType _type;

        public int Id { get; private set; }
        public int ClientId
        {
            get
            {
                return _client.Id;
            }
        }
        public string ClientName
        {
            get
            {
                return _client.Name;
            }
        }
        public DateTimeOffset? EndedOn { get; private set; }
        public DateTimeOffset StartedOn { get; private set; }
        public int WorkTypeId
        {
            get
            {
                return _type.Id;
            }
        }
        public string WorkTypeName
        {
            get
            {
                return _type.Name;
            }
        }

        public WorkDone() { }

        public WorkDone(int id)
        {
            Id = id;
        }

        public WorkDone(int id, Client client, WorkType workType, DateTimeOffset startedOn, DateTimeOffset? endedOn) : this(client, workType, startedOn, endedOn)
        {
            Id = id;
        }

        public WorkDone(Client client, WorkType workType)
        {
            _client = client;
            _type = workType;
            StartedOn = DateTimeOffset.Now;
        }

        public WorkDone(Client client, WorkType workType, DateTimeOffset startedOn) : this(client, workType)
        {
            StartedOn = startedOn;
        }

        public WorkDone(Client client, WorkType workType, DateTimeOffset startedOn, DateTimeOffset? endedOn) : this(client, workType, startedOn)
        {
            EndedOn = endedOn;
        }

        public void Finished()
        {
            if (EndedOn.HasValue)
            {
                EndedOn = DateTimeOffset.Now;
            }
        }

        public decimal? GetTotal()
        {
            if (EndedOn.HasValue)
            {
                return _type.Rate * (EndedOn - StartedOn).Value.Hours;
            }
            return null;
        }
    }
}