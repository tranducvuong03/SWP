import React from 'react'
import { Link } from 'react-router-dom';
function Sosanh_sp() {
    return (
        <div>

            {/* breadcrumb area start */}
            <div class="breadcrumb-area">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="breadcrumb-wrap">
                                <nav aria-label="breadcrumb">
                                    <ul class="breadcrumb">
                                        <li class="breadcrumb-item">
                                            <Link to="/">
                                                <i class="fa fa-home"></i>
                                            </Link>
                                        </li>
                                        <li class="breadcrumb-item">
                                            <Link to="shop.html">Cửa hàng
                                            </Link>
                                        </li>
                                        <li class="breadcrumb-item active"
                                            aria-current="page">So sánh
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            {/* breadcrumb area end */}

            {/* compare main wrapper start */}
            <div class="compare-page-wrapper section-padding">
                <div class="container">
                    <div class="section-bg-color">
                        <div class="row">
                            <div class="col-lg-12">
                                {/* Compare Page Content Start */}
                                <div class="compare-page-content-wrap">
                                    <div class="compare-table table-responsive">
                                        <table class="table table-bordered mb-0">
                                            <tbody>
                                                <tr>
                                                    <td class="first-column">Sản phẩm
                                                    </td>
                                                    <td class="product-image-title">
                                                        <a href="product-details.html"
                                                            class="image">
                                                            <img class="img-fluid"
                                                                src="assets/img/product/product-1.jpg" alt="Compare Product" />
                                                        </a>
                                                        <a href="#"
                                                            class="category">Kim cương
                                                        </a>
                                                        <a href="product-details.html"
                                                            class="title">Perfect Diamond Jewelry
                                                        </a>
                                                    </td>
                                                    <td class="product-image-title">
                                                        <Link to="product-details.html" class="image">
                                                            <img class="img-fluid"
                                                                src="assets/img/product/product-2.jpg" alt="Compare Product" />
                                                        </Link>
                                                        <a href="#" class="category">Gold</a>
                                                        <a href="product-details.html" class="title">Handmade Golden Necklace</a>
                                                    </td>
                                                    <td class="product-image-title">
                                                        <a href="product-details.html" class="image">
                                                            <img class="img-fluid" src="assets/img/product/product-3.jpg" alt="Compare Product" />
                                                        </a>
                                                        <a href="#" class="category">Nhẫn Kim Cương</a>
                                                        <a href="product-details.html" class="title">Nhẫn Nam Kim Cương Vàng Trắng 14K</a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Mô tả</td>
                                                    <td class="pro-desc">
                                                        <p>Kết hợp hoàn hảo giữa vàng trắng 14K và kim cương tinh khiết,
                                                            tạo nên trang sức tinh tế và sang trọng,
                                                            tôn lên vẻ đẹp và đẳng cấp của người đeo.</p>
                                                    </td>
                                                    <td class="pro-desc">
                                                        <p>Sự kết hợp hoàn mỹ giữa vàng 18K và kim cương lấp lánh,
                                                            tạo nên trang sức đẳng cấp và sang trọng,
                                                            tôn vinh vẻ đẹp và phong cách tinh tế của người đeo.</p>
                                                    </td>
                                                    <td class="pro-desc">
                                                        <p>Sự kết hợp hoàn hảo giữa vàng trắng 14K và kim cương lấp lánh,
                                                            tạo nên món trang sức sang trọng và đẳng cấp,
                                                            tôn lên vẻ nam tính và phong cách riêng.</p>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Giá Thành</td>
                                                    <td class="pro-price">$295</td>
                                                    <td class="pro-price">$275</td>
                                                    <td class="pro-price">$395</td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Màu Sắc</td>
                                                    <td class="pro-color">Đen</td>
                                                    <td class="pro-color">Đỏ</td>
                                                    <td class="pro-color">Xanh</td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Tình Trạng</td>
                                                    <td class="pro-stock">Còn Hàng</td>
                                                    <td class="pro-stock">Hết Hàng</td>
                                                    <td class="pro-stock">Còn Hàng</td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Thêm vào giỏ hàng</td>
                                                    <td><a href="cart.html" class="btn btn-sqr">Thêm vào giỏ hàng</a></td>
                                                    <td><a href="cart.html" class="btn btn-sqr disabled">Thêm vào giỏ hàng</a></td>
                                                    <td><a href="cart.html" class="btn btn-sqr">Thêm vào giỏ hàng</a></td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Đánh Giá</td>
                                                    <td class="pro-ratting">
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star-o"></i>
                                                    </td>
                                                    <td class="pro-ratting">
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                    </td>
                                                    <td class="pro-ratting">
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star-o"></i>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="first-column">Xóa</td>
                                                    <td class="pro-remove">
                                                        <button><i class="fa fa-trash-o"></i></button>
                                                    </td>
                                                    <td class="pro-remove">
                                                        <button><i class="fa fa-trash-o"></i></button>
                                                    </td>
                                                    <td class="pro-remove">
                                                        <button><i class="fa fa-trash-o"></i></button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                {/* Compare Page Content End */}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            {/* compare main wrapper end */}

        </div>
    )
}

export default Sosanh_sp
