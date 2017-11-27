using Sudoku_comp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_comp
{
    [ContractClass(typeof(StackContract))]
    public interface IContract
    {
        [Pure]
        Boolean CheckHorizontally();

        [Pure]
        Boolean CheckVertically();

        [Pure]
        Boolean CheckBox();

        [Pure]
        Boolean CheckIfSolved();

        [Pure]
        Boolean NotEmptyBoard();

        [Pure]
        Boolean FieldIsNotEmpty();

        void NewBoard();
    }

    
}

[ContractClassFor(typeof(IContract))]

internal abstract class StackContract : IContract
{
    [ContractInvariantMethod]
    private void ObjectInvariant()
    {
        Contract.Ensures(Contract.Result<int>() != 0);
    }
    public bool CheckBox()
    {
        throw new NotImplementedException();
    }

    public bool CheckHorizontally()
    {
        throw new NotImplementedException();
    }

    public bool CheckIfSolved()
    {
        throw new NotImplementedException();
    }

    public bool CheckVertically()
    {
        throw new NotImplementedException();
    }

    public bool FieldIsNotEmpty()
    {
        throw new NotImplementedException();
    }

    public void NewBoard()
    {
        throw new NotImplementedException();
    }

    public bool NotEmptyBoard()
    {
        throw new NotImplementedException();
    }




}
