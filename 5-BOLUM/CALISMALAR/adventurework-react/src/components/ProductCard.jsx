import 'react';
import PropTypes from 'prop-types';

const ProductCard = ({ product }) => {
    const imageSrc = product.productPhoto
        ? `data:image/jpeg;base64,${product.productPhoto}`
        : 'https://via.placeholder.com/150';

    return (
        <div className="col-md-3 mb-4">
            <div className="card">
                <img className="card-img-top" src={imageSrc} alt={product.name} />
                <div className="card-body">
                    <h5 className="card-title">{product.name}</h5>
                    <p className="card-text">Price: ${product.listPrice}</p>
                </div>
            </div>
        </div>
    );
};

export default ProductCard;


ProductCard.propTypes = {
    product: PropTypes.shape({
        productId: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired, // Ürün ID'si
        name: PropTypes.string.isRequired, // Ürün adı
        productNumber: PropTypes.string.isRequired, // Ürün numarası
        color: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Renk
        standardCost: PropTypes.number.isRequired, // Standart maliyet
        listPrice: PropTypes.number.isRequired, // Liste fiyatı
        size: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Boyut
        sizeUnitMeasureCode: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Boyut birim kodu
        weight: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Ağırlık
        weightUnitMeasureCode: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ağırlık birim kodu
        style: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Stil
        productSubcategoryId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Alt kategori ID'si
        productModelId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Ürün model ID'si
        productCategoryId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Kategori ID'si
        productCategoryName: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Kategori adı
        productSubcategoryName: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Alt kategori adı
        productPhoto: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ürün fotoğrafı
        productDescription: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ürün açıklaması
    }).isRequired, // product prop'u zorunludur
};