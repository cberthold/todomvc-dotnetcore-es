using System;
using Xunit;

namespace TodoMVC.Domain.Tests
{
    public class TodoListAggregateTests
    {
        [Fact]
        public void Test1()
        {

        }

        private TodoListAggregate given_new_todo_list_aggregate()
        {
            var aggregate = new TodoListAggregate();
            return aggregate;
        }
    }
}
