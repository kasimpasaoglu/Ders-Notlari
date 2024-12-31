const categorySelector = $('#category');
const subcategorySelector = $('#subcategory');
const pageSize = 20;
let currentPage = 1;

$(document).ready(function () {
    loadCategories();
    loadProducts();

    // Event handlers
    categorySelector.on('change', fetchSubcategories);
    subcategorySelector.on('change', fetchProducts);
});

function loadCategories() {
    $.ajax({
        url: 'http://adventureworks.runasp.net/api/Filters/categories',
        method: 'GET',
        success: function (categories) {
            categories.forEach(category => {
                categorySelector.append(
                    $('<option>', {
                        value: category.productCategoryId,
                        text: category.name
                    })
                );
            });
        },
        error: function (xhr, status, error) {
            console.error('Kategori yüklenirken bir hata oluştu:', error);
        }
    });
}

function loadProducts(filters = {}) {
    const requestData = {
        page: currentPage,
        productRequested: pageSize,
        ...filters
    };

    $.ajax({
        url: 'http://adventureworks.runasp.net/api/Products',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(requestData),
        success: function (products) {
            renderProducts(products);
        },
        error: function (xhr, status, error) {
            console.error('Ürünler yüklenirken bir hata oluştu:', xhr.responseText || error);
        }
    });
}

function renderProducts(products) {
    const productList = $('#product-list');
    productList.empty();

    products.forEach(product => {
        const base64Image = product.productPhoto
            ? `data:image/jpeg;base64,${product.productPhoto}`
            : 'https://via.placeholder.com/150';

        productList.append(
            $('<div>', {
                class: 'col-md-3 mb-4',
                html: $('<div>', {
                    class: 'card',
                    html: `
                        <img class="card-img-top" src="${base64Image}" alt="${product.name}">
                        <div class="card-body">
                            <h5 class="card-title">${product.name}</h5>
                            <p class="card-text">Price: $${product.listPrice}</p>
                        </div>
                    `
                })
            })
        );
    });
}

function fetchSubcategories() {
    const selCategoryId = categorySelector.val();
    if (!selCategoryId) {
        resetSubcategories();
        return;
    }

    $.ajax({
        url: `http://adventureworks.runasp.net/api/Filters/categories/${selCategoryId}`,
        method: 'GET',
        success: function (subcategories) {
            updateSubcategories(subcategories);
        },
        error: function (xhr, status, error) {
            console.error('Alt kategoriler yüklenirken bir hata oluştu:', error);
        }
    });

    loadProducts({ categoryId: selCategoryId });
}

function fetchProducts() {
    const selCategoryId = categorySelector.val();
    const selSubcategoryId = subcategorySelector.val();

    loadProducts({
        categoryId: selCategoryId,
        subcategoryId: selSubcategoryId
    });
}

function resetSubcategories() {
    subcategorySelector.empty();
    subcategorySelector.append('<option value="">All Subcategories</option>');
}

function updateSubcategories(subcategories) {
    resetSubcategories();
    subcategories.forEach(subCategory => {
        subcategorySelector.append(
            $('<option>', {
                value: subCategory.productSubcategoryId,
                text: subCategory.name
            })
        );
    });
}
