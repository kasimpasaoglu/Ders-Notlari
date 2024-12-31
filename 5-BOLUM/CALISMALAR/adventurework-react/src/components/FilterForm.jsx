import { useState } from 'react';
import PropTypes from 'prop-types';

const FilterForm = ({ categories, subcategories, onFilterChange }) => {
    const [selectedCategory, setSelectedCategory] = useState('');
    const [selectedSubcategory, setSelectedSubcategory] = useState('');


    const handleApplyFilters = () => {
        onFilterChange({ categoryId: selectedCategory || null, subcategoryId: selectedSubcategory || null });
    };





    return (
        <form>
            <div className="mb-3">
                <label htmlFor="category" className="form-label">Category</label>
                <select
                    id="category"
                    className="form-select"
                    value={selectedCategory}
                    onChange={(e) => setSelectedCategory(e.target.value)}
                >
                    <option value="">All Categories</option>
                    {categories.map((cat) => (
                        <option key={cat.productCategoryId} value={cat.productCategoryId}>
                            {cat.name}
                        </option>
                    ))}
                </select>
            </div>

            <div className="mb-3">
                <label htmlFor="subcategory" className="form-label">Subcategory</label>
                <select
                    id="subcategory"
                    className="form-select"
                    value={selectedSubcategory}
                    onChange={(e) => setSelectedSubcategory(e.target.value)}
                >
                    <option value="">All Subcategories</option>
                    {subcategories.map((sub) => (
                        <option key={sub.productSubcategoryId} value={sub.productSubcategoryId}>
                            {sub.name}
                        </option>
                    ))}

                </select>
            </div>

            <button type="button" className="btn btn-primary w-100" onClick={handleApplyFilters}>
                Apply Filters
            </button>
        </form>
    );
};

FilterForm.propTypes = {
    categories: PropTypes.arrayOf(
        PropTypes.shape({
            productCategoryId: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired,
            name: PropTypes.string.isRequired,
        })
    ).isRequired, // categories bir dizi ve her elemanı belirli bir yapıya sahip
    subcategories: PropTypes.arrayOf(
        PropTypes.shape({
            productSubcategoryId: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired,
            name: PropTypes.string.isRequired,
        })
    ).isRequired,
    onFilterChange: PropTypes.func.isRequired,
};
export default FilterForm;
