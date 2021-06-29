using OrmLight.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Obsolete
{
    //public class Command<T> : ISimpleQueryable<T> where T : BaseEntity
    //{
    //    private DataAccesLayer _dal;
    //    public Type EntityType { get; private set; }

    //    Command<T> ISimpleQueryable<T>.Command => throw new NotImplementedException();

    //    private List<IEntity> _entities;
    //    private List<ICondition> _conditions;
    //    private List<ISorting> _sortings;

    //    public Command(DataAccesLayer dal)
    //    {
    //        EntityType = typeof(T);
    //        _entities = new List<IEntity>();
    //        _conditions = new List<ICondition>();
    //        _sortings = new List<ISorting>();
    //    }

    //    public Command(List<IEntity> entities) : this()
    //    {
    //        _entities = entities;
    //    }

    //    public Command(IEntity entity) : this(new List<IEntity>() { entity })
    //    {
    //    }

    //    public Command(List<IEntity> entities, List<ICondition> conditions = null, List<ISorting> sortings = null) : this(entities)
    //    {
    //        _conditions = conditions;
    //        _sortings = sortings;
    //    }

    //    public void Add(T ent) => _entities.Add(ent);

    //    public void AddCondition(ICondition con) => _conditions.Add(con);

    //    public void AddSorting(ISorting sort) => _sortings.Add(sort);

    //    public Command<T> Where(Expression<Func<T, bool>> predicate)
    //    {
    //        return new Command<T>();
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ISimpleQueryable<T> CreateNewCommand(Command<T> command)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public TResult Execute<TResult>()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
