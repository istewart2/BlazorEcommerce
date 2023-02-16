window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Success!", {timeout: 5000});
    }

    if (type === "error") {
        toastr.error(message, "Error!", { timeout: 5000 });
    }
}