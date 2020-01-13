function GetRelativePos(svg, evt) {
    var pt = svg.createSVGPoint();
    pt.x = evt.clientX;
    pt.y = evt.clientY;
    // The cursor point, translated into svg coordinates
    var cursorpt = pt.matrixTransform(svg.getScreenCTM().inverse());
    return [Math.round(cursorpt.x), Math.round(cursorpt.y)];
} 
