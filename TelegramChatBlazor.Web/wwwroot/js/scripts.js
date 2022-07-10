﻿
window.jsMethod = () => {
    var margin = 10,
        instance3 = new emojiButtonList("emojiButton", {
            dropDownXAlign: "center",
            dropDownYAlign: "top",
            textBoxID: "textMessage",
            yAlignMargin: margin,
            xAlignMargin: margin
        });
}



window.scrollToElementId = (elementId) => {
    console.info('scrolling to element', elementId);
    var element = document.getElementById(elementId);
    console.info('element', element);
    if (!element) {
        console.warn('element was not found', elementId);
    } else {
        element.scrollTop = element.scrollHeight;
    }
}
