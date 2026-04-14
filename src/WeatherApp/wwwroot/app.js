window.getGeolocation = () => {
    return new Promise((resolve, reject) => {
        if (!navigator.geolocation) {
            reject('Geolocation not supported');
            return;
        }
        navigator.geolocation.getCurrentPosition(
            pos => resolve([pos.coords.latitude, pos.coords.longitude]),
            err => reject(err.message),
            { timeout: 10000 }
        );
    });
};

window.getBrowserTimezone = () => {
    return Intl.DateTimeFormat().resolvedOptions().timeZone;
};