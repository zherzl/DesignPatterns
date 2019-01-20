using System;

namespace Model
{
    public interface IEmployeeRepository
    {
        Employee FindBy(Guid Id);

    }
}