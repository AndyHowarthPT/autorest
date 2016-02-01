# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from .pet import Pet


class Cat(Pet):

    _required = []

    _attribute_map = {
        'color': {'key': 'color', 'type': 'str'},
        'hates': {'key': 'hates', 'type': '[Dog]'},
    }

    def __init__(self, *args, **kwargs):
        """Cat

        :param str color
        :param list hates
        """
        self.color = None
        self.hates = None

        super(Cat, self).__init__(*args, **kwargs)