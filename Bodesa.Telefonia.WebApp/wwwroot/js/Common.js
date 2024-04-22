window.ShowToastr = (type, message) => {

    toastr.options.toastClass = "toastr";

    if (type === "success") {
        toastr.success(message, "Successful", { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, "Failed", { timeOut: 5000 });
    }
    if (type === "warning") {
        toastr.warning(message, "Warning", {timeOut : 5000})
    }
    if (type === "info") {
        toastr.info(message, "Informativo", {timeOut : 5000})
    }

}
