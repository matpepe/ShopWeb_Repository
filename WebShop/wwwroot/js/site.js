// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


$("form").removeData("validator");


$(":input[data-val-required]").attr("data-val-required", "Polje je obavezno za unos.");
$(":input[data-val-length]").attr("data-val-length", "Morate unijeti minimalno {0} znaka.");


$.validator.unobtrusive.parse(document);

