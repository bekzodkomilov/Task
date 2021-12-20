namespace tasks.Mapper
{
    public static class EnumMappers
    {
         public static Entity.ETaskPriorety ToEntityETaskPriorety(this Model.ETaskPriorety? priority)
        {
            return priority switch
            {
                Model.ETaskPriorety.High => Entity.ETaskPriorety.High,
                Model.ETaskPriorety.Mid => Entity.ETaskPriorety.Mid,
                Model.ETaskPriorety.Low => Entity.ETaskPriorety.Low,
                _ => Entity.ETaskPriorety.None,
            };
        }

        public static Entity.ETaskStatus ToEntityETaskStatus(this Model.ETaskStatus? status)
        {
            return status switch
            {
                Model.ETaskStatus.Completed => Entity.ETaskStatus.Completed,
                Model.ETaskStatus.InProgress => Entity.ETaskStatus.InProgress,
                Model.ETaskStatus.Postponed => Entity.ETaskStatus.Postponed,
                _ => Entity.ETaskStatus.None,
            };
        }

        public static Entity.ETaskRepeat ToEntityETaskRepeat(this Model.ETaskRepeat? repeat)
        {
            return repeat switch
            {
                Model.ETaskRepeat.Daily => Entity.ETaskRepeat.Daily,
                Model.ETaskRepeat.Hourly => Entity.ETaskRepeat.Hourly,
                Model.ETaskRepeat.Monthly => Entity.ETaskRepeat.Monthly,
                Model.ETaskRepeat.Weekly => Entity.ETaskRepeat.Weekly,
                Model.ETaskRepeat.Yearly => Entity.ETaskRepeat.Yearly,
                _ => Entity.ETaskRepeat.Never
            };
        }


        // public static Model.ETaskRepeat ToModelETaskRepeat(this Entity.ETaskRepeat repeat)
        // {
        //     return repeat switch
        //     {
        //         Entity.ETaskRepeat.Hourly => Model.ETaskRepeat.Hourly,
        //         Entity.ETaskRepeat.Daily => Model.ETaskRepeat.Daily,
        //         Entity.ETaskRepeat.Weekly => Model.ETaskRepeat.Weekly,
        //         Entity.ETaskRepeat.Monthly => Model.ETaskRepeat.Monthly,
        //         Entity.ETaskRepeat.Yearly => Model.ETaskRepeat.Yearly,
        //         _ => Model.ETaskRepeat.Never,
        //     };
        // }

        // public static Model.ETaskStatus ToModelETaskStatus(this Entity.ETaskStatus status)
        // {
        //     return status switch
        //     {
        //         Entity.ETaskStatus.InProgress => Model.ETaskStatus.InProgress,
        //         Entity.ETaskStatus.Postponed => Model.ETaskStatus.Postponed,
        //         Entity.ETaskStatus.Completed => Model.ETaskStatus.Completed,
        //         _ => Model.ETaskStatus.None,
        //     };
        // }

        // public static Model.ETaskPriorety ToModelETaskPriorety(this Entity.ETaskPriorety priorety)
        // {
        //     return priorety switch
        //     {
        //         Entity.ETaskPriorety.Low => Model.ETaskPriorety.Low,
        //         Entity.ETaskPriorety.Mid => Model.ETaskPriorety.Mid,
        //         Entity.ETaskPriorety.High => Model.ETaskPriorety.High,
        //         _ => Model.ETaskPriorety.None,
        //     };
        // }
    }
}