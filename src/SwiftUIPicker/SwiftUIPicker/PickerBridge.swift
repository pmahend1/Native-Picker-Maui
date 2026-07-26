//
//  PickerBridge.swift
//  SwiftUIPicker
//
//  Created by Prateek Mahendrakar on 7/25/26.
//
import Combine
import Foundation
import SwiftUI
import UIKit

public class PickerBridge: NSObject, ObservableObject {
    // MARK: - Properties

    @Published var selectedItem: String {
        didSet { onSelectionChanged?(selectedItem); refreshView() }
    }

    @Published var items: [String] {
        didSet { refreshView() }
    }

    @Published var title: String {
        didSet { refreshView() }
    }

    @Published var style: NativePickerStyle {
        didSet { refreshView() }
    }

    private var hostingController: UIHostingController<NativePicker>?
    private var onSelectionChanged: ((String) -> Void)?

    public var uiView: UIView? {
        hostingController?.view
    }

    // MARK: - Init

    public init(title: String,
                items: [String],
                selected: String,
                style: NativePickerStyle,
                onSelectionChanged: @escaping (String) -> Void) {
        self.items = items
        selectedItem = selected
        self.title = title
        self.style = style
        self.onSelectionChanged = onSelectionChanged
        super.init()
        hostingController = UIHostingController(rootView: makeView())
    }

    private func makeView() -> NativePicker {
        let binding = Binding<String>(get: { self.selectedItem },
                                      set: { self.selectedItem = $0 })

        return NativePicker(title: title,
                            items: items,
                            selectedItem: binding,
                            style: style)
    }

    private func refreshView() {
        hostingController?.rootView = makeView()
    }

    // MARK: - Handlers

    public func setSelected(_ item: String) {
        selectedItem = item
    }

    public func updateItems(_ newItems: [String]) {
        items = newItems
    }

    public func updateTitle(_ newTitle: String) {
        title = newTitle
    }

    public func updateStyle(_ newStyle: NativePickerStyle) {
        style = newStyle
    }
}
