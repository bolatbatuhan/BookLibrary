using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using CorePackages.Aspects.Autofac.Validation;
using CorePackages.Utilities.Business;
using CorePackages.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Entities.DTOs.ResponseDto;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    [ValidationAspect(typeof(CategoryValidator))]
    public IResult Add(CategoryAddRequest categoryAddRequest)
    {
        IResult result = BusinessRules.Run(CheckIfCategoryNameExits(categoryAddRequest.CategoryName));
        if (result != null)
        {
            return result;
        }
        _categoryDal.Add(categoryAddRequest);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Delete(int categoryId)
    {
        Category category = _categoryDal.Get(c => categoryId == categoryId);
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }

    public IDataResult<List<Category>> GetAll()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.AllCategoriesListed);
    }

    public IDataResult<CategoryResponseDto> GetById(int categoryId)
    {
        return new SuccessDataResult<CategoryResponseDto>(_categoryDal.Get(c => c.CategoryId == categoryId));
    }

    [ValidationAspect(typeof(CategoryValidator))]
    public IResult Update(CategoryUpdateRequest categoryUpdateRequest)
    {
        _categoryDal.Update(categoryUpdateRequest);
        return new SuccessResult(Messages.CategoryUpdated);
    }
    private IResult CheckIfCategoryNameExits(string categoryName)
    {
        var result = _categoryDal.GetAll(c=>c.CategoryName == categoryName).Any();
        if(result)
        {
            return new ErrorResult(Messages.CategoryNameAldreadyExits);
        }
        return new SuccessResult();
    }
}
